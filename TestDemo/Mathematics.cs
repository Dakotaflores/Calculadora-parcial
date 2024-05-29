
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace TestDemo; 
public static class Mathematics { 
//Calculo de fuerza
public static double Calculodefuerza(double masa, double aceleracion) { 
return (masa * aceleracion); 
} 

//Calculo de trabajo
public static double Calculodetrabajo(double fuerza, double distancia) { 
return (fuerza * distancia); 
} 

//Calculo de energia cinetica 
public static double EnergiaCinetica(double masa) { 
double velocidad = 4 * 4; 
double result = (velocidad * masa * 0.5);
return (result); 
} 
} 


