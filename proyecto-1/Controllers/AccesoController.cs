﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proyecto_1.Models;

namespace proyecto_1.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(int documento, string password)
        {
            try
            {
               
                using (practicaprofesionalEntities db = new practicaprofesionalEntities())
                {
                    
                    var lst = from d in db.empleado
                              where d.dni == documento && d.Contraseña == password
                              select d;

                    if (lst.Count() > 0)
                    {
                         
                        empleado oEmpleado = lst.First();
                        Session["usuario"] = oEmpleado.id_empleado;
                        Session["comercio"] = oEmpleado.id_comercio;
                        Session["tipo"] = oEmpleado.id_tipo;
                        Session["nombre"] = oEmpleado.nombre;
                        Session["empleado"] = oEmpleado;


                        var lt = from d in db.comercio
                                  where d.id_comercio == oEmpleado.id_comercio
                                  select d;

                        if(lt.Count() > 0)
                        {
                            comercio oComercio = lt.First();
                            Session["nombrecomercio"] = oComercio.razon_social;

                        }
                        



                        return Content("1");
                    }
                    else
                    {
                        return Content("no se encontro al usuario");
                    }
                }

                
               
            }
            catch(Exception e)
            {
                return Content("ocurrio un error" + e.Message);
            }
        }

    }
}