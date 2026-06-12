/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

if(ValidateLength() && ValidateZeroes() && ValidateRange())
{
     Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
     Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength() {}
void ValidateZeroes() {}
void ValidateRange() {}