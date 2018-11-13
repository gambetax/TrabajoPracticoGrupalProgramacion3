namespace ConsoleApp1.Conexion
{
    public interface Insertable
    {
        // metodos pueden funcionar para cualquier tabla, con dato especifico o no

        string getOrderedFields();

        string getOrderedValues();

        string getIdField(); 

        string getIdValue();

    }
}