function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      const input = document.querySelector('#inputs textarea').value;
      const bestRestaurant = document.querySelector('#bestRestaurant p')
      const workers = document.querySelector('#workers p')
      const regex = /"([^"]*)"/g;
      const matches = [];
      let match;
      const output = {};

      while ((match = regex.exec(input)) !== null) {
         matches.push(match[1]);
      }

      for (const entry of matches) {
         const [restaurantName, employeesData] = entry.split(' - ');

         if (!Object.hasOwn(output, restaurantName)) {
            output[restaurantName] = {
               employees: [],
               averageSalary: 0
            };
         }

         employeesData.split(', ').forEach(employee => {
            const [name, salary] = employee.split(' ');
            output[restaurantName].employees.push({
               name: name,
               salary: +salary
            });
         })

         const employees = output[restaurantName].employees;
         const totalSalary = employees.reduce((sum, employee) => sum + employee.salary, 0);
         output[restaurantName].averageSalary = totalSalary / employees.length;
      }

      for (const restaurant in output) {
         output[restaurant].employees.sort((a, b) => b.salary - a.salary);
      }

      const sortedOutput = Object.entries(output).sort((a, b) => b[1].averageSalary - a[1].averageSalary);
      const best = sortedOutput[0];
      bestRestaurant.textContent = `Name: ${best[0]} Average Salary: ${best[1].averageSalary.toFixed(2)} Best Salary: ${best[1].employees[0].salary.toFixed(2)}`;

      let workersText = '';
      best[1].employees.forEach(e => workersText += `Name: ${e.name} With Salary: ${e.salary} `);
      workers.textContent = workersText.trim();
   }
}