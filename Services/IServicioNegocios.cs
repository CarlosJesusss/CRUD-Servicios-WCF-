using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioNegocios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioNegocios
    {
        [OperationContract]
        void DoWork();

        [OperationContract] List<Producto> Listaproductos();

        [OperationContract] string AgregarProductos(Producto reg);

        [OperationContract] string ActualizarProducto(Producto reg);

        [OperationContract] Producto DetalleProducto(string id);

        [OperationContract] string EliminarProducto(string cod);
    }

    [DataContract]
    public class Producto {
        [DataMember] public string IdProducto { set; get; }
        [DataMember]public string NombreProducto { set; get; }
        [DataMember] public double Precio { set; get; }
        [DataMember] public int Stock { set; get; }
    }

}
