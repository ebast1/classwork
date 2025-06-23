// Create an array of eight objects

// each has
// name : string
// inner : boolean
// diameter : number
// color : string

class Planet {
    constructor(name, inner, diameter, color) {
        this.name = name;
        this.inner = inner;
        this.diameter = diameter;
        this.color = color;
    }
}

const planets = [
    new Planet("Mercury", true, 3031.9, "#696969"),
    new Planet("Venus", true, 7520.8, "#b89165"),
    new Planet("Earth", true, 7917.5, "#5a5b86"),
    new Planet("Mars", true, 4212.3, "df8c4e"),
    new Planet("Jupiter", false, 86881, "f6a049"),
    new Planet("Saturn", false, 72367, "dcd3a1"),
    new Planet("Uranus", false, 31518, "b4d9df"),
    new Planet("Neptune", false, 30599, "456eff")
];

function logPlanets(planets) {
    for (let i =0; i < planets.length; i++) {
        console.log(planets[i]);
    }
}

function avgDiameter(planetNames) {

    let totalDiameter = 0;
    let count = 0;

    for (const planet of planetNames) {
        console.log(planet.name);
    }

    for (let i = 0; i < planetNames.length; i++) {
        totalDiameter += planetNames[i].diameter;
        count++;
    }

    return totalDiameter / count;
}

// Index variable to hold the current shown planet's index.

let index = 0;
let planetName = planets[index].name;
let innerOrOuter = planets[index].inner ? "Inner" : "Outer";
let planetColor = planets[index].color;
let planetDiameter = planets[index].diameter;

const indexDisplay = document.getElementById('index');
const planetNameDisplay = document.getElementById('planet-name');
const innerOrOuterDisplay = document.getElementById('inner-outer');
const planetColorDisplay = document.getElementById('planet-color');
const planetDiameterDisplay = document.getElementById('planet-diameter');

const prevButton = document.getElementById('prev');
const nextButton = document.getElementById('next');

function updatePlanetDisplay() {
    indexDisplay.innerText = index;
    planetNameDisplay.innerText = planetName;
    innerOrOuterDisplay.innerText = innerOrOuter;
    planetColorDisplay.innerText = planetColor;
    planetDiameterDisplay.innerText = planetDiameter;
    
    console.log(`Current index: ${index}`);
    console.log(`Planet name: ${planetName}`);
    console.log(`Inner or Outer: ${innerOrOuter}`);
    console.log(`Planet color: ${planetColor}`);
    console.log(`Planet diameter: ${planetDiameter}`);
}

prevButton.addEventListener("click", () => {
    if (index > 0) {
        index--;
        updatePlanetDisplay();
    }});

nextButton.addEventListener("click", () => {
        index++;
        updatePlanetDisplay();
    });