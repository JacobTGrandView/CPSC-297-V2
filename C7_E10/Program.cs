using System;

class enrollmentReport
{
    // data members for the name of the course, current enrollment, and maximum enrollment
    string nameOfCourse;
    int currentEnrollment;
    int maximumEnrollment;

    // initialize enrollmentReport
    public enrollmentReport(string nameOfCourse, int currentEnrollment, int maximumEnrollment)
    {
        this.nameOfCourse = nameOfCourse;
        this.currentEnrollment = currentEnrollment;
        this.maximumEnrollment = maximumEnrollment;
    }

    // method that returns the number of students that can still enroll in the course
    public int canStillEnroll()
    {
        // this returns the number of open slots
        return maximumEnrollment - currentEnrollment;
    }

    // override ToString() method
    public override string ToString()
    {
        // return formatted course details
        return "Name of course: " + nameOfCourse + "\nCurrent enrollment: " + currentEnrollment + "\nEnrollment slots left: " + canStillEnroll();
    }
}


// implementation class
class implementationReport
{
    static void Main(string[] args)
    {
        // array of data for the courses
        string[] nameOfCourses = { "CS150", "CS250", "CS270", "CS300", "CS350" };
        int[] currentEnrollments = { 180, 21, 9, 4, 20 };
        int[] maximumEnrollments = { 200, 30, 20, 20, 20 };

        // new array called 'courses' from enrollmentReport class
        enrollmentReport[] courses = new enrollmentReport[nameOfCourses.Length]; // ensure array same size

        // loop through nameOfCourses array 
        for (int i = 0; i < nameOfCourses.Length; i++)
        {
            // Create new enrollmentReport object from array data and store in courses array
            courses[i] = new enrollmentReport(nameOfCourses[i], currentEnrollments[i], maximumEnrollments[i]);
        }

        // Print enrollment report
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }
    }
}