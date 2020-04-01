using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Server.Helpers
{
    public static class ExtensionsRemoval
    {

        public async static void RemoveGeneral(ApplicationDbContext context, int? generalId)
        {
            var general = await context.General.FirstOrDefaultAsync(x => x.Id == generalId);

            if (general != null)
            {
                context.Remove(general);
            }
        }
    }
}
