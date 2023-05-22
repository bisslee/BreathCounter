document.title = "Breath Counter";

let timerTicker = 0;
let breathTypeCounter = 0;
let breathType = { Inspira: 0, Expira: 1 };

const instructionsDisplayLabel = document.getElementById(
  "instructionsDisplayLabel"
);
const appVersionDisplay = document.getElementById("appVersionDisplay");
const timeInput = document.getElementById("timeInput");
const seriesInput = document.getElementById("seriesInput");
const startButton = document.getElementById("startButton");
const seriesDisplay = document.getElementById("seriesDisplay");
const breathTypeDisplay = document.getElementById("breathTypeDisplay");
const timerDisplay = document.getElementById("timerDisplay");


breathTypeDisplay.classList.add("bigDisplay");

instructionsDisplayLabel.innerText =
  "Respire e prenda a respiração pelo tempo determinado no contador. " +
  "Assim que o contador de tempo reiniciar, solte lentamente a respiração.\n\n" +
  "O contador de série irá informar quantas séries faltam";

appVersionDisplay.innerText = "Biss.BreathCounter v1.0.0 - Biss Solution ";

startButton.addEventListener("click", startButtonClicked);

let currentSeries = 0;

function changeBreathType(breathTypeCounter) {
  let selectedBreathType = Object.keys(breathType)[breathTypeCounter];
  console.log("selectedBreathType", selectedBreathType);
  breathTypeDisplay.textContent = selectedBreathType;
  while (breathTypeDisplay.classList.length > 0) {
    breathTypeDisplay.classList.remove(breathTypeDisplay.classList.item(0));
  }
  
  breathTypeDisplay.classList.add("bigDisplay", selectedBreathType);
}

function formCleaner() {
  seriesDisplay.textContent = "00";
  breathTypeDisplay.innerHTML = "&nbsp;";
  breathTypeDisplay.classList.add("bigDisplay");

  timerDisplay.textContent = "00";
  timeInput.value = "";
  seriesInput.value = "";
}

function startButtonClicked() {
  if (timeInput.value == "" || seriesInput.value == "") {
    alert("Preencha os campos de tempo e série");
    return;
  }
  
  if (currentSeries == 0){
    currentSeries = parseInt(seriesInput.value);
  }

  seriesDisplay.textContent = currentSeries;

  let timeInSeconds = parseInt(timeInput.value);

  let intervalInspiration = setInterval(function () {
    changeBreathType(0);
    timerDisplay.textContent = timeInSeconds;
    timeInSeconds--;

    if (timeInSeconds < 0) {
      clearInterval(intervalInspiration);
      startExpirationInterval();
    }
  }, 1000);
}

function startExpirationInterval() {
  let timeInSeconds = parseInt(timeInput.value);

  let intervalExpiration = setInterval(function () {
    changeBreathType(1);
    timerDisplay.textContent = timeInSeconds;
    timeInSeconds--;

    if (timeInSeconds < 0) {
      clearInterval(intervalExpiration);
      currentSeries--;
      console.log("currentSeries 1", currentSeries);
      seriesDisplay.textContent = currentSeries;

      if (currentSeries > 0) {
        startButtonClicked();
      } else {
        breathTypeDisplay.textContent ="Processo finalizado!";
        setTimeout(function () {
        formCleaner();}, 2000);
      }
    }
  }, 1000);
}
