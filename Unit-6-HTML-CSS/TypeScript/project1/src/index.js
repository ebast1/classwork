// typescript file goes here
console.log("Welcome to My First TypeScript Program");
//  Define a class that will hold and process all the Students
var Roster = /** @class */ (function () {
    function Roster() {
        this.studentList = []; // Initialize array to be emtpy 
    }
    // A methood to add a Student to the Roster
    Roster.prototype.addStudent = function (newStudent) {
        this.studentList.push(newStudent);
    };
    // Class method to return the entire Roster
    Roster.prototype.getAllTheStudents = function () {
        return this.studentList;
    };
    return Roster;
}()); // End of class Roster
/*
    Code the use our Roster class
*/
var classRoster = new Roster();
classRoster.addStudent({ studentName: "Frank", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Zach", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "India", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Kiana", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Youssef", className: "of his own", startDate: 20260623 });
var aStudent = { studentName: "Jay", className: "Advanced Angular", startDate: 20250723 };
classRoster.addStudent(aStudent);
// Display all the students in our Roster
classRoster.getAllTheStudents().forEach(function (aStudent) { console.log(aStudent); });
