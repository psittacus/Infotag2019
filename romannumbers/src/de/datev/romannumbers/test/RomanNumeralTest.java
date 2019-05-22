package de.datev.romannumbers.test;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import de.datev.romannumbers.RomanNumeral;

public class RomanNumeralTest {

	@Test
	public void TestOn1() {
		
		//Arrange - Anordnen
		String exp = "I";
		
		//Act - Ausführen
		String res = RomanNumeral.convertArabicToRomanNumeral(1);
		
		//Assert - Überprüfen
		assertEquals(exp, res);
	}
	
}
