using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GlobalWealthPyramid
{
    public class GlobalWealthPercentage
    {
        public List<GlobalWealthModel> GlobalWealthData { get; set; }
        public List<Brush> PaletteBrushes { get; set; }

        [Obsolete]
        public GlobalWealthPercentage()
        {

            GlobalWealthData = new List<GlobalWealthModel>()
        {
            new GlobalWealthModel()
            {
                WealthPercentage = 1.2,
                AdultsCount = 62.5,
                PopulationRange = ">$1 million",
                Color = Color.FromHex("#95DB9C")
            },
            new GlobalWealthModel()
            {
                WealthPercentage = 11.8,
                AdultsCount = 627,
                PopulationRange = "$100,000 to $1 million",
                Color = Color.FromHex("#B95375")
            },
            new GlobalWealthModel()
            {
                WealthPercentage = 33.8,
                AdultsCount = 1791,
                PopulationRange = "$10,000 to $100,000",
                Color = Color.FromHex("#56BBAF")
            },
            new GlobalWealthModel()
            {
                WealthPercentage = 53.2,
                AdultsCount = 2818,
                PopulationRange = "<$10,000",
                Color = Color.FromHex("#606D7F")
            }
        };

            PaletteBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#95DB9C")),
                new SolidColorBrush(Color.FromArgb("#B95375")),
                new SolidColorBrush(Color.FromArgb("#56BBAF")),
                new SolidColorBrush(Color.FromArgb("#606D7F")),
            };
        }
    }
}
