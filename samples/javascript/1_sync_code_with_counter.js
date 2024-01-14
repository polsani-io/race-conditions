let counter = 0;

function main() {
    incrementCounter();
    console.log(`The final value of counter is: ${counter}`);
}

function incrementCounter() {
    for (let i = 0; i < 1000000; i++) {
        counter++;
    }
}

main();
