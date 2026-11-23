#include <iostream>
#include <ctime> // Including the C Standard Library header for time functions

int main()
{
 // current date and time in current system using time_t data type
 time_t current_dt = time(0); // Get the current system time in seconds since epoch (Jan 1, 1970)

 // convert date time to string format using ctime function
 char *result = ctime(&current_dt); // Convert the time_t value to a string representing local time

 // Display the current date and time in string format
 std::cout << "The current date and time is:\n" << result << '\n';

 return 0;
}