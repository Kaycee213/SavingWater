using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavingWaterApi.Data
{
    public static class SeedData
    {
        public static void Initialize(UserContext context)
        {
            if (!context.UserInfo.Any())
            {
                context.UserInfo.AddRange(
                );
                context.SaveChanges();
            }
        }
    }
}
