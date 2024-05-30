function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      const input = document.querySelector('#inputs textarea').value;
      const bestRestaurantElem = document.querySelector('#bestRestaurant p');
      const workersElem = document.querySelector('#workers p');
      const regex = /"([^"]*)"/g;
      const matches = [];
      let match;
      const restaurants = {};

      while ((match = regex.exec(input)) != null) {
         matches.push(match[1]);
      }

      matches.forEach(entry => {
         const [restaurantName, employeesData] = entry.split(' - ');

         if (!restaurants[restaurantName]) {
            restaurants[restaurantName] = { employees: [], averageSalary: 0 };
         }

         employeesData.split(', ').forEach(employee => {
            const [name, salary] = employee.split(' ');
            restaurants[restaurantName].employees.push({ name, salary: +salary });
         });
      });

      Object.values(restaurants).forEach(restaurant => {
         const totalSalary = restaurant.employees.reduce((sum, employee) => sum + employee.salary, 0);
         restaurant.averageSalary = totalSalary / restaurant.employees.length;
         restaurant.employees.sort((a, b) => b.salary - a.salary);
      });

      const sortedRestaurants = Object.entries(restaurants).sort((a, b) => b[1].averageSalary - a[1].averageSalary);
      const bestRestaurant = sortedRestaurants[0];

      bestRestaurantElem.textContent = `Name: ${bestRestaurant[0]} Average Salary: ${bestRestaurant[1].averageSalary.toFixed(2)} Best Salary: ${bestRestaurant[1].employees[0].salary.toFixed(2)}`;

      const workersText = bestRestaurant[1].employees.map(e => `Name: ${e.name} With Salary: ${e.salary}`).join(' ');
      workersElem.textContent = workersText;
   }
}