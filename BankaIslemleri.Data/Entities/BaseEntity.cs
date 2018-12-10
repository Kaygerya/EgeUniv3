using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
        public bool IsSuccess {
            get
            {
                return Errors.Count == 0;
            }
        }
    }
}
