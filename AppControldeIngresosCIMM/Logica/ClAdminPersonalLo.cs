using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClAdminPersonalLo
    {
        public List<ClAdmPersonalEn> mtdListar()
        {
            ClAdministradorPersonal objPersonalD = new ClAdministradorPersonal();
            List<ClAdmPersonalEn> listarPersonal = objPersonalD.mtdListTable();
            return listarPersonal;
        }

        public List<ClAdmPersonalEn> mtdIdPersonal(int IdPersonal)
        {
            ClAdministradorPersonal objPersonalD = new ClAdministradorPersonal();
            List<ClAdmPersonalEn> listaTable = objPersonalD.mtdObtenerPersonalPorId(IdPersonal);
            return listaTable;
        }

        public int mtdActualizacion(ClAdmPersonalEn objDatos)
        {
            ClAdministradorPersonal objPersonalD = new ClAdministradorPersonal();
            int actu = objPersonalD.mtdActualizar(objDatos);
            return actu;
        }

        public int mtdEliminar(ClAdmPersonalEn objDatos)
        {
            ClAdministradorPersonal objPersonalD = new ClAdministradorPersonal();
            int Eliminar = objPersonalD.mtdEliminar(objDatos);
            return Eliminar;
        }

    }
}