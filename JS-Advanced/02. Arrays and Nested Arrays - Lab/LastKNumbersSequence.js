function solve(num1, num2) {
  let arr = [1]
  for (let i = 1; i < num1; i++) {
      arr.push(arr.slice(-num2).reduce((a, b) => a + b, 0))
  }
  return arr;
}
console.log(solve(6, 3));

console.log(solve(6,3));