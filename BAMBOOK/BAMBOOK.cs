using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMBOOK
    {
    static class BAMBOOK
        {
        public static string GetLastSuccessfullBuildNumber(this Bamboo.Sharp.Api.Model.Plan plan)
            {
            return plan.BuildName;
            }

        static void Main(string[] args)
            {
            Bamboo.Sharp.Api.BambooApi bamboo = new Bamboo.Sharp.Api.BambooApi("Bamboo.acumatica.com", "buildilka", "Aw34esz");
            var PRservice = bamboo.GetService<Bamboo.Sharp.Api.Services.ProjectService>();
            var plans = PRservice.GetProjects().All.Single(p=>p.Name.Equals("acumatica")).Plans.All;
            foreach (var plan in plans) Console.WriteLine(plan.GetLastSuccessfullBuildNumber());
            }
        }
    }
