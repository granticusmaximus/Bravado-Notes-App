using System.Collections.Generic;
using Bravado_Notes_App.Models.Wiki;

namespace Bravado_Notes_App.ViewModels.EntryViewModels
{
    public class EntryViewModel
    {
        public List<Entry> Entries {get;set;}
        public Entry Entry {get;set;}
        public string SearchString {get;set;}
    }
}