using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld4.Models
{
    public class MyFormData
    {
        public string Name { get; set; }
        public bool IsTrue { get; set; }
        public string SomeValue { get; set; }

        // We chose to supply the select list via the model... not necessarily the "right" thing to do.
        // This gets a bit complicated; the goal is to generate a SelectList, but the origin is created as a dictionary.
        // The SelectList constructor appears to be able to handle it if properly "guided" (by telling it the property names of the KeyValuePair elements)
        public static SelectList Numbers = new SelectList(new Dictionary<string, string>
        {
            { "1", "One"},
            { "2", "Two"},
            { "3", "Three"},
            { "4", "Four" }
        },
        "Key", "Value", null);
    }
}