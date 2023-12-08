import * as fs from 'fs';
const input = fs.readFileSync('./input.txt').toString().trim();

let hanoiArr=[];
hanoi(input, 1, 2, 3);
let result = "";

console.log(hanoiArr.length);
for(let i=0; i < hanoiArr.length; i++) {
    consol
}
console.log(result);

function hanoi(count, from, to, temp) {
    if(count == 0) return;
    hanoi(count - 1, from, temp, to);
    hanoiArr.push([from, to]);
    hanoi(count - 1, temp, to, from);
}