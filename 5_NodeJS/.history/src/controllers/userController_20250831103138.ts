import express  from "express"

export const userController = express.Router()

// userLogin
userController.get("/", (req, res) => {
    res.render('login')
})
userCont
