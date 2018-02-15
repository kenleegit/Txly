using System;

namespace Txly
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        //Reference: https://stackoverflow.com/questions/24496941/deserialisation-of-a-nested-json-object-with-newtonsoft-in-c-sharp
    }
}
