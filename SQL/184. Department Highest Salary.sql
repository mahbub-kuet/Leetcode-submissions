# https://leetcode.com/problems/department-highest-salary/

# Write your MySQL query statement below

select sub.name as department ,e.name as employee ,e.salary as salary from Employee e,
    (select max(salary) as salary,d.id as id , d.name as name 
        from Employee e,Department d 
            where e.departmentId=d.id group by d.id
    ) sub 
where e.departmentId=sub.id and e.salary = sub.salary