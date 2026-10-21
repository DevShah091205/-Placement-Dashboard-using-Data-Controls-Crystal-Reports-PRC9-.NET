USE PlacementDB;
GO
-- Dashboard counts
SELECT COUNT(*) AS TotalStudents FROM dbo.Student;
SELECT COUNT(DISTINCT StudentId) AS PlacedStudents FROM dbo.Placement WHERE PlacementStatus='Placed';
SELECT COUNT(*) AS TotalCompanies FROM dbo.Company;
SELECT AVG(PackageLPA) AS AveragePackageLPA FROM dbo.Placement WHERE PlacementStatus='Placed';
-- Joined report
SELECT s.EnrollmentNo,s.StudentName,s.Department,c.CompanyName,c.JobRole,
       p.PackageLPA,p.PlacementStatus,p.PlacementDate
FROM dbo.Placement p
JOIN dbo.Student s ON s.StudentId=p.StudentId
JOIN dbo.Company c ON c.CompanyId=p.CompanyId
ORDER BY s.StudentName;
