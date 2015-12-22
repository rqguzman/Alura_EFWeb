using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWebEF.Filters
{
    public class SaveChangesFilter : ActionFilterAttribute
    {
        private EntidadesContext _context;

        public SaveChangesFilter(EntidadesContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception == null)
            {
                _context.SaveChanges();
            }
            _context.Dispose();
        }
    }
}