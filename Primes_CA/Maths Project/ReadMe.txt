-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                                                     K00191419 - Maths Project
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

Welcome to the SD2 Maths Main Project by K00191419

This file contains instructions on how to use this software package.

Main Menu:
	QI - QVI - Show tabs that have interface that can be used to execute Programs 1 to
                                6 as specified in project specifications.

	Help      - Displays this ReadMe file and contains "Generate Report" button that will 
	               generate report containing answers to questions asked in project
                               specification

QI: Tests if a number entered is a prime number.

	To test if a given number is prime:
	1.) Enter number in a "Enter number:" field
	2.) Press "Check" button. The result message will be displayed.
	
	To test a set of values for primality:
	1.) Press "Check Multiple" button. A new window will open
	2.) Enter numbers separated by space into input field
	3.) Press "Check Numbers" button to test numbers. A file named "Q1.txt" containing
                     answers will be generated in the same folder as this program's executable file.
		
QII: Finds the prime factors of a given number

	To find prime factors of a given number:

	1.) Enter number in a "Enter number:" field
	2.) Press "Factorize" button. A list of factors will appear in "Factor List" text box.
	
	To find prime factors of a set of values:

	1.) Press "Factorize Multiple" button. A new window will open
	2.) Enter numbers separated by space into input field
	3.) Press "Factorize" button to find all prime factors of each number entered. A file
                     named "Q2.txt" containing answers will be generated in the same folder as this 
                     program's file.
	
QIII: Finds a Greatest Common Divisor of two numbers

	To determine GCD of two numbers:

	1.) Enter numbers 'a' and 'b' into input fields.
	2.) Press "Compute GCD" button. The result message will be displayed.
	
	To determine GCD of multiple pairs of numbers:

	1.) Press "Compute Multiple" button. A new window will open containing a set of 
                     default pairs.
	2.) Press "Clear All" to clear default pairs list.
	3.) Enter numbers 'a' and 'b' into input fields.
	4.) Press "Add" button to add two numbers to the computation list. The numbers 
                     entered will appear in the text box below.
	5.) Press "Compute" button to find GCD of each set of values. A file named Q3.txt"
                     containing answers will be generated in the same folder as this program's 
                     executable file.
		
QIV: Uses Extended Euclidean Algorithm to determine GCD and coefficients of equation 
	 GCD(a,b) = a*x + b*y

	To determine GCD and coefficients using Extended Euclidean Algorithm:
	1.) Enter numbers 'a' and 'b' into input fields.
	2.) Press "Compute" button. The results will appear in corresponding text boxes.
	
	To apply Extended Euclidean Algorithm to multiple pairs of numbers:
	1.) Press "Compute Multiple" button. A new window will open containing a set of 
                     default pairs.
	2.) Press "Clear All" to clear default pairs list.
	3.) Enter numbers 'a' and 'b' into input fields.
	4.) Press "Add" button to add two numbers to the computation list. The numbers 
                     entered will appear in the text box below.
	5.) Press "Compute" button to find GCD and coefficients for each set of values. A
                      file named "Q4.txt" containing answers will be generated in the same folder as 
                     this program's executable file.
		
QV: Encrypt plaintext message encoded as integer number using RSA Algorithm

	To encode a plaintext message:
	1.) Enter a message as integer number into "Enter message:" field.
	2.) Enter encryption exponent and RSA modulus used for encryption into.These 
                     values, if not known, can be generated using a built-in program by pressing 
                     Generate Keys" button.
	3.) Press "Encrypt" button. An encrypted cyphertext will appear under "Cyphertext:" 
                     label.
	
QVI: Decrypt cyphertext using RSA Algorithm

	To decode an encrypted by RSA Algorithm message:
	1.) Enter cyphertext into "Enter cyphertext:" field.
	2.) Enter Dectyption Exponent and RSA modulus used as a private key into fields. 
                     These values, if not known, can be generated using a built-in program by                
                     pressing "Generate Keys" button.
	3.) Press "Decrypt" button. A decrypted text will appear under "Plaintext Message:" 
                     label.
	
Generate Keys facility: 
	This program generates private and public key components from the two supplied 
                 prime numbers.
	A program can also be given a specific encryption exponent, however if not known, 
	 it can be generated.
	
	To determine RSA encryption keys:
	1.) Enter prime numbers 'p' and 'q' into corresponding fields. Please note that a 
                     program WILL NOT test entered numbers for primality.
	2.) Enter a selected encryption exponent. If not known, it can be generated by 
                     pressing "Generate e" button.
	3.) Press "Generate" button. an RSA modulus n = p*q, a Phi(p,q) and decryption 
                     key 'd' wil appear in corresponding text boxes.
	4.) Press OK to close Generate RSA Keys window.

NOTE: The "Generate Report" button will create a report based on output files from Q1-Q4