using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeScraper.Lib
{
    [Serializable]
    public class nutrition
    {

        public string calories { get; set; }
        public string fatContent { get; set; }
        public string saturatedFatContent { get; set; }
        public string proteinContent { get; set; }
        public string carbohydrateContent { get; set; }
        public string sugarContent { get; set; }
        public string sodiumContent { get; set; }
        public string fiberContent { get; set; }
        public string NutritionInformation { get; set; }
    }


    [Serializable]
    public class recipe
    {

        public string image { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string totalTime { get; set; }
        public string recipeYield { get; set; }

        public string autor { get; set; }
        public nutrition nutrition { get; set; }
        public IList<string> recipeIngtredient { get; set; }
        public recipe()
        {
            this.nutrition = new nutrition();
        }
    }
}
