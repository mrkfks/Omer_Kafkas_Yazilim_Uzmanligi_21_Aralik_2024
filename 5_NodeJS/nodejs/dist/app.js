"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const path_1 = __importDefault(require("path"));
const body_parser_1 = __importDefault(require("body-parser"));
const db_1 = require("./utils/db");
const app = (0, express_1.default)();
const PORT = process.env.PORT || 3000;
// DB Config
(0, db_1.connectDB)();
// EJS Configuration
app.set("views", path_1.default.join(__dirname, "views"));
app.set("view engine", "ejs");
// body-parser Config
app.use(body_parser_1.default.urlencoded({ extended: false }));
app.use(body_parser_1.default.json());
// imports controllers
const userController_1 = require("./controllers/userController");
const dashboardController_1 = require("./controllers/dashboardController");
// Controllers
app.use("/", userController_1.userController);
app.use("/dashboard", dashboardController_1.dashboardController);
app.listen(PORT, () => {
    console.log(`Server running: http://localhost:${PORT}`);
});
//# sourceMappingURL=app.js.map