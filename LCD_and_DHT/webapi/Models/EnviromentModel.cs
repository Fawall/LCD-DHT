using System.ComponentModel.DataAnnotations;

namespace webapi.Models{
    public class EnviromentModel {

        [Key]
        public long EnviromentId {get; set;}
        public float Temperature {get; set;}
        public float Humidity {get; set;}

        public DateTime Time { get; set; }


    }

}

