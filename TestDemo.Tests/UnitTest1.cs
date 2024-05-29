 
namespace TestDemo.Tests; 
public class UnitTest1 { 
[Fact] 
public void Calculodefuerza() { 
    //Calculo de fuerza
//Arrange 
double masa = 3.15; 
double aceleracion = 9.36;
double expectedResult = 29.484;
//Act 
double result = Mathematics.Calculodefuerza(masa, aceleracion); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void Calculodetrabajo() { 
    //Calculo de trabajo
//Arrange 
double fuerza = 10;
double distancia = 17;
double expectedResult = 170;
//Act 
double result = Mathematics.Calculodetrabajo(fuerza, distancia); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void Energiacinetica() { 
    //Calculo de conversion de metros cubicos a litros
//Arrange 
double masa = 3.15; 
double expectedResult = 25.2;
//Act 
double result= Mathematics.EnergiaCinetica(masa); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
} 
