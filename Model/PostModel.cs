using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class PostModel
    {
        public int id { get; set; }
        public int daste_id { get; set; }
        public int user_id { get; set; }
        public string gheimat { get; set; }
        public string onvan { get; set; }
        public string tozihat { get; set; }
        public int vaziat_forosh { get; set; }
        public string img { get; set; }
        public string shomare_tamas { get; set; }
        [DataType(DataType.Date)]
        public DateTime tarikht_sabt { get; set; }
        public bool is_active{get;set;}


        public PostModel(
            int id,
            int daste_id,
            int user_id,
            string gheimat,
            string onvan,
            string tozihat,
            int vaziat_forosh,
            string img,
            string shomare_tamas,
            DateTime tarikh_sabt,
            bool is_active)
        {
            this.id = id;
            this.daste_id = daste_id;
            this.user_id = user_id;
            this.gheimat = gheimat;
            this.onvan = onvan;
            this.tozihat = tozihat;
            this.vaziat_forosh = vaziat_forosh;
            this.img = img;
            this.shomare_tamas = shomare_tamas;
            this.tarikht_sabt = tarikht_sabt;
            this.is_active = is_active;

        }
       
    }
}