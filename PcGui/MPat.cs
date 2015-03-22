using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    public class MPat
    {
        [DataMember]
        private Int32 TestFood { get; set; }
        private List[] ListaProcedimiento { get; set; } // Lista con los pasos del procedimiento de la MPAT
        private Int32 CiclosMasticatorios { get; set; } // Almacena el nº de ciclos masticatorios
        private Int32 CiclosEvaluacion { get; set; } // Almacena el nº de ciclos de evaluación
        private enum Estado
        {
            ACEPTADO = 1, RECHAZADO, PENDIENTE
        }  // Estado en el que se encuentra la MPAT. 
        private String VectorW { get; set; } //almacena el resultado de la MPAT entrenada

        public MPat()
        {
            this.TestFood = 0;
            this.ListaProcedimiento = List[].Empty;
            this.CiclosMasticatorios = 0;
            this.CiclosEvaluacion = 0;
            this.Estado = PENDIENTE;
            this.VectorW = String.Empty;
        }
    }
}