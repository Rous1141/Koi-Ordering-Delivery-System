﻿using System;
using KDOS_Web_API.Datas;
using KDOS_Web_API.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace KDOS_Web_API.Repositories
{
	public class SQLFishProfileRepository : IFishProfileRepository
	{
        private readonly KDOSDbContext profileContext;

        public SQLFishProfileRepository(KDOSDbContext profileContext)
		{
            this.profileContext = profileContext;
        }
        public async Task<FishProfile?> AddNewFishProfile(FishProfile fishProfile)
        {
            var koifishModel = await profileContext.KoiFish.FirstOrDefaultAsync(x => x.KoiFishId == fishProfile.KoiFishId);
            var customerModel = await profileContext.Customer.FirstOrDefaultAsync(x => x.CustomerId == fishProfile.CustomerId);
            if(customerModel == null || koifishModel==null)
            {
                return null;
            }
            await profileContext.FishProfile.AddAsync(fishProfile);
            await profileContext.SaveChangesAsync();
            return fishProfile;
        }

        public async Task<FishProfile?> DeleteProfile(int id)
        {
            var profileModel = await profileContext.FishProfile.FirstOrDefaultAsync(x => x.FishProfileId == id);
            var orderDetail = await profileContext.OrderDetails.FirstOrDefaultAsync(x => x.FishProfileId == id);
            if(profileModel != null && orderDetail==null)
            {
                profileContext.FishProfile.Remove(profileModel);
                await profileContext.SaveChangesAsync();
                return profileModel;
            }
            return null;
        }

        public async Task<List<FishProfile>> GetAllProfile()
        {
            return await profileContext.FishProfile.Include("KoiFish").ToListAsync();
        }

        public async Task<List<FishProfile>> GetProfileByCustomerId(int id)
        {
            return await profileContext.FishProfile.Include(x=>x.KoiFish).Where(x => x.CustomerId == id).ToListAsync();
        }

        public async Task<FishProfile?> GetProfileById(int id)
        {
            return await profileContext.FishProfile.Include("KoiFish").FirstOrDefaultAsync(x => x.FishProfileId == id);
        }

        public async Task<FishProfile?> UpdateFishProfile(int id, FishProfile fishProfile)
        {
            var profileModel = await profileContext.FishProfile.FirstOrDefaultAsync(x => x.FishProfileId == id);
            if (profileModel == null)
            {
                return null;
            }
            profileModel.Gender = fishProfile.Gender;
            profileModel.Weight = fishProfile.Weight;
            profileModel.Notes = fishProfile.Notes;
            await profileContext.SaveChangesAsync();
            return fishProfile;
        }
    }
}

