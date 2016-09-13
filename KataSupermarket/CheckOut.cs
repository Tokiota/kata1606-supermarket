using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSupermarket
{
    public class CheckOut
    {
        private readonly List<Item> items = new List<Item>();
        private readonly List<PricingRule> pricingRules = new List<PricingRule>();


        public int CalculateTotal()
        {
            int total = 0;
            var itemGroups = items.GroupBy(g => g.Name);

            foreach (var itemGroup in itemGroups)
            {
                total += PriceTotalForEachGroup(itemGroup);
            }
            return total;
        }

        private int PriceTotalForEachGroup(IGrouping<string, Item> itemGroup)
        {
            decimal? total = 0;
            var ruleForGroup = pricingRules.FirstOrDefault(r => r.ItemName == itemGroup.Key);
            if (ruleForGroup != null)
            {
                var extra = itemGroup.Count() - ruleForGroup.ItemCount;
                if (extra < 0)
                {
                    total += itemGroup.Sum(g => g.Price);
                }
                else
                {
                    total += ruleForGroup.Total;
                    total += extra * itemGroup.First().Price;
                }
            }
            else
            {
                total += itemGroup.Sum(x => x.Price);
            }

            return (int)total;
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void AddPricingRule(PricingRule rule)
        {
            if (rule == null)
            {
                throw new ArgumentNullException("The rule cannot be null");
            }

            if (string.IsNullOrWhiteSpace(rule.ItemName))
            {
                throw new ArgumentException("The itenName cannot be whiteSpace or null");
            }

            pricingRules.Add(rule);
        }
    }
}
