import express from 'express'
import path from 'path'
import5

const app = express()
const PORT = process.env.PORT || 3000

// EJS Configuration
app.set("views", path.join(__dirname, "views"))
app.set("view engine", "ejs")

// imports controllers
import { userController } from './controllers/userController'

// Controllera
app.use("/", userController)

app.listen(PORT, () => {
  console.log(`Server running: http://localhost:${PORT}`)
})
