 function test() {
    console.log("Hello world");
}

function test2(num1, num2) {
    return (num1 + num2);
}


test();
let sum = test2(12, 45);
console.log(sum);
//using arrow functions
const testme = () => console.log("Hello world2");
let sum2 = (n1, n2) => (n1 + n2);
testme();
console.log(sum2(12, 56));

