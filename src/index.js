import "./styles.css";
import Moveable from "moveable";

const innerElement = document.querySelector("#inner");

const innerMoveable = new Moveable(innerElement.parentElement, {
  target: innerElement,
  origin: false,
  resizable: true,
  snappable: true,
  snapCenter: true,
  snapThreshold: 5,
  verticalGuidelines: [0, 150, 300],
  horizontalGuidelines: [0, 150, 300],
  snapElement: true,
  snapGap: false,
  isDisplaySnapDigit: false
});

innerMoveable.on("resize", ({ target, width, height }) => {
  target.style.height = `${height}px`;
  target.style.width = `${width}px`;
});
