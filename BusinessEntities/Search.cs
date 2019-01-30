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
                string[] strs = _searchText.Split(' ');
                ListSearchText.Clear();
                for(int i=0; i<strs.Length; i++)
                {
                    string x = strs[i].Trim();
                    if (x.Length>0)
                    {
                        ListSearchText.Add(x);
                    }
                }
            }
                
        }
        public List<String> ListSearchText { get; }

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
