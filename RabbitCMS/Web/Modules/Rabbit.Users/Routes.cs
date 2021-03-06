﻿using Rabbit.Web;
using Rabbit.Web.Routes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Rabbit.Users
{
    internal sealed class Routes : IRouteProvider
    {
        #region Implementation of IRouteProvider

        /// <summary>
        /// 获取路由信息。
        /// </summary>
        /// <param name="routes">路由集合。</param>
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            const string area = "Rabbit.Users";

            routes.MapRabbitRoute("Rabbit.Users_Default", "Admin/Users/{controller}/{action}/{id}",
                area, new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        #endregion Implementation of IRouteProvider
    }
}