package Tes_Unitarios;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class CalculadoraTest {

	/*@Test
	void test() {
		fail("Not yet implemented");
	}*/

	@Test
    public void testSumar() {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.sumar(3, 4);
        assertEquals(7, resultado);
    }

    @Test
    public void testRestar() {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.restar(5, 2);
        assertEquals(3, resultado);
    }
	
}


// Varios ejemplos de que se debe utilizar serian estos
/*
assertEquals(expected, actual):
Descripción: Compara dos valores para verificar si son iguales.
	assertEquals(3, resultado);
	

assertTrue(booleanCondition):
Descripción: Verifica que la condición booleana sea verdadera.
	assertTrue(resultado > 0);
	
	
assertFalse(booleanCondition):
Descripción: Verifica que la condición booleana sea falsa.
	assertFalse(resultado < 0);


assertNull(object):
Descripción: Verifica que el objeto sea nulo
	assertNull(objetoNulo);


assertNotNull(object):
Descripción: Verifica que el objeto no sea nulo.
 	assertNotNull(objetoNoNulo);


assertSame(expected, actual):
Descripción: Verifica que ambos objetos se refieran al mismo objeto en memoria. 
	assertSame(objeto1, objeto2);


assertNotSame(expected, actual):
Descripción: Verifica que ambos objetos no se refieran al mismo objeto en memoria.
 	assertNotSame(objeto1, objeto2);


assertArrayEquals(expectedArray, resultArray):
Descripción: Compara dos arreglos para verificar que sean iguales.
	assertArrayEquals(new int[]{1, 2, 3}, resultadoArray);


assertThrows(exceptionClass, executable):
Descripción: Verifica que la ejecución de un código arroje una excepción específica.
	assertThrows(ArithmeticException.class, () -> {
    int resultado = 1 / 0;
	});
	
	
fail(message):
Descripción: Marca la prueba como fallida con un mensaje personalizado.	
	if (resultado < 0) {
    fail("El resultado no debe ser negativo");
	}

 
 
 */
 