using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using RevolentData.Models;

namespace RevolentData.Controllers
{
    public class MoviesController : ApiController
    {
        // GET api/values
        public IEnumerable<MovieShortInfo> Get()
        {
            var data = (programs)HttpContext.Current.Application["data"];
            return data.program.Select(prog=> new MovieShortInfo(){Titles=prog.titles,TMSID=prog.TMSId }) ;
        }

        // GET api/values/5
        public SerializableProgram Get(string id)
        {
            var data = (programs)HttpContext.Current.Application["data"];
            var p=data.program.Where(s => s.TMSId == id).FirstOrDefault();

            return new SerializableProgram(p);
        }

       public IEnumerable<MovieShortInfo> GetByTitle(string title)
       {
           var data = (programs)HttpContext.Current.Application["data"];
           	if(data.program !=null) 
			return data.program.Where(x=>x.titles.Any(t=>t.Value.ToLower().Contains(title.ToLower())))
				.Select(prog=>new MovieShortInfo(){Titles=prog.titles,TMSID=prog.TMSId }) ;
			else
				return new List<MovieShortInfo>();
       }
    }
}