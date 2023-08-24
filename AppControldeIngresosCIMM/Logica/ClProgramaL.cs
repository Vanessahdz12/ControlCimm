using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClProgramaL
    {
        ClProgramaD registrar_program = new ClProgramaD();
        public string mtdRegistrarPrograma(string nombre, string ficha, string descripcion)
        {
           return registrar_program.mtdRegistrarPrograma(nombre, ficha, descripcion);
        }

        public List<ClProgramaE> mtdListarPrograma()
        {
            ClProgramaD objPrograma = new ClProgramaD();
            List<ClProgramaE> listaPrograma = objPrograma.mtdListarProgramas();
            return listaPrograma;
        }

        public List<ClProgramaE> mtdListarPorId(int idPrograma)
        {
            ClProgramaD objPrograma = new ClProgramaD();
            List<ClProgramaE> ListaProgramas = objPrograma.mtdListarProgramaPorID(idPrograma);
            return ListaProgramas;
        }

        public int mtdActualizacion(ClProgramaE objDatos)
        {
            ClProgramaD objPersonalD = new ClProgramaD();
            int actu = objPersonalD.mtdActualizarPrograma(objDatos);
            return actu;
        }

        public int mtdEliminar(ClProgramaE objDatos)
        {
            ClProgramaD objPersonalD = new ClProgramaD();
            int Eliminar = objPersonalD.mtdEliminar(objDatos);
            return Eliminar;
        }
    }
}