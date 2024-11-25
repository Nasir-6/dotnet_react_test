import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

// This is just a basic array - where you want to setup the routes to various pages - TODO: use this in the NavMenu aswell to keep it DRY
// Nothing special - it works with react-dom-router
const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  }
];

export default AppRoutes;
