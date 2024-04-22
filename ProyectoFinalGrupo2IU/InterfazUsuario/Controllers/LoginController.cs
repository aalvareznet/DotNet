using InterfazUsuario.Models;
using InterfazUsuario.ReferenciaSrvSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfazUsuario.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login()
        {
            Session["opcMantCR"] = false;
            Session["opcContactos"] = false;
            Session["Logueado"] = false;
            return View();
        }

        public ActionResult errorIngreso()
        {
            return View();
        }

        public ActionResult errorUsuario()
        {
            return View();
        }

        public ActionResult accesoUsuario(Login pLogin)
        {
            string lRuta = string.Empty;
            TUSR_USUARIOS lObjRespuesta = new TUSR_USUARIOS();
            List<PA_recPerfilesXUsuario_Result> lObjRespuestaPerfiles =
                new List<PA_recPerfilesXUsuario_Result>();

            try
            {
                using (ReferenciaSrvSeguridad.IsrvSeguridadClient lSrvSeg = new
                    ReferenciaSrvSeguridad.IsrvSeguridadClient())
                {
                    lObjRespuesta = lSrvSeg.recUsuario(pLogin.usuario);
                    if (lObjRespuesta != null)
                    {
                        if (lObjRespuesta.TC_Usuario == pLogin.usuario &&
                            lObjRespuesta.TC_Contrasena == pLogin.contrasena)
                        {
                            lRuta = "../Home/Index";
                            Session["Logueado"] = true;

                            lObjRespuestaPerfiles = lSrvSeg.recPerfilesPorUsuario(pLogin.usuario).ToList();
                            if (lObjRespuestaPerfiles.Count > 0)
                            {
                                foreach (var perfil in lObjRespuestaPerfiles)
                                {
                                    switch (perfil.TN_Perfil)
                                    {
                                        case 1:
                                            Session["opcMantCR"] = true;
                                            break;
                                        case 2:
                                            Session["opcContactos"] = true;
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lRuta = "../Login/errorIngreso";
                        }
                    }
                    else
                    {
                        lRuta = "../Login/errorUsuario";
                    }
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return RedirectToAction(lRuta);
        }

        public ActionResult retornarLogin()
        {
            return RedirectToAction("../Login/login");
        }
    }
}