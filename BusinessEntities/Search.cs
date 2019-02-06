using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPRTSearch.BusinessEntities
{
    public class Search
    {
        private string _searchText;

        [SearchTextValidation]
        public string SearchText {
            get {return _searchText; }
            set{ _searchText = value;
                            }
                
        }
        public List<String> ListSearchText {
            get { 
                string[] strs = _searchText.Split(' ');
                List<string> listSearchText = new List<string>(); 
                for (int i = 0; i < strs.Length; i++)
                {
                    string x = strs[i].Trim();
                    if (x.Length > 0)
                    {
                        listSearchText.Add(x);
                    }
                }
                return listSearchText;
            }
        }
        public Navigation navigation { get; set; }
        public Search()
        {
            navigation = new Navigation();
            
        }

    }
    public class SearchTextValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) // Checking for Empty Value
            {
                return new ValidationResult("Please Provide Search Content");
            }
            else
            {
                if (value.ToString().Trim().Length==0)
                {
                    return new ValidationResult("Content should not only be space");
                }
            }
            return ValidationResult.Success;
        }
    }
}
