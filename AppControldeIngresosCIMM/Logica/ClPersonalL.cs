using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClPersonalL
    {
        public List<ClPersonalE> mtdListar()
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdLista();
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscar(string tipoper="", string ficha="")
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdBuscar(tipoper,ficha);
            return listaPersonal;
        }

        public List<ClPersonalE> mtdListarPorteriaPeatonal()
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdListaArticulosPorterias();
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscarPorteriaPeatonal(string tipoper = "", string porteria = "")
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdBuscarArticulosPorterias(tipoper, porteria);
            return listaPersonal;
        }

        public List<ClPersonalE> mtdListarVehiculoPorterias()
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdListaVehiculosPorterias();
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscarVehiculosPorteria(string tipoper = "", string porteria ="")
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> listaPersonal = objPersonal.mtdBuscarVehiculosPorterias(tipoper, porteria);
            return listaPersonal;
        }

        public List<ClPersonalE> mtdListarPersonal()
        {
            ClPersonalD objPersonalD = new ClPersonalD();
            List<ClPersonalE> listarPersonal = objPersonalD.mtdListarPersonalPrograma();
            return listarPersonal;
        }


        public List<ClPersonalE> mtdIdPersonal(int IdPersonal)
        {
            ClPersonalD objPersonalD = new ClPersonalD();
            List<ClPersonalE> listaTable = objPersonalD.mtdObtenerPersonalPorId(IdPersonal);
            return listaTable;
        }

        public int mtdActualizacion(ClPersonalE objDatos)
        {
            ClPersonalD objPersonalD = new ClPersonalD();
            int actu = objPersonalD.mtdActualizarPersonaPrograma(objDatos);
            return actu;
        }

        public int mtdEliminar(int objDatos)
        {
            ClPersonalD objPersonalD = new ClPersonalD();
            int Eliminar = objPersonalD.mtdEliminarPersonal(objDatos);
            return Eliminar;
        }

        public List<ClPersonalE> mtdListarIngresoSalidaPersonal()
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> lista = objPersonal.mtdListarIngresoSalidaPersonal();
            return lista;
        }

        public List<ClPersonalE> mtdDetallesVehiculo()
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> lista = objPersonal.mtdDetallesVehiculo();
            return lista;
        }
    }
}