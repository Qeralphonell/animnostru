int encoding = 10; // Replace 10 with your actual decimal number
string binaryRepresentation = Convert.ToString(encoding, 2).PadLeft(4, '0');
modeIndicator += binaryRepresentation;
