package de.datev.romannumbers.test;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import de.datev.romannumbers.RomanNumeral;

public class RomanNumeralTest {

	@Test
	public void TestOn1() {
		
		//Arrange - Anordnen
		String exp = "I";
		
		//Act - Ausf�hren
		String res = RomanNumeral.convertArabicToRomanNumeral(1);
		
		//Assert - �berpr�fen
		assertEquals(exp, res);
	}
	
}
