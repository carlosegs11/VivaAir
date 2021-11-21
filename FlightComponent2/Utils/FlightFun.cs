using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightComponent2.Utils
{
    public class FlightFun
    {
        public List<SelectListItem> GetCities(List<ModelLayer.City> cityList, int seleccionar)
        {

            List<SelectListItem> itemList = new List<SelectListItem>();

            foreach (ModelLayer.City item in cityList)
            {
                bool Seleccionado = false;
                if (item.Id == seleccionar) { Seleccionado = true; } else { Seleccionado = false; }

                itemList.Add(
                new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                    Selected = Seleccionado
                });

            }

            return itemList;
        }
    }
}