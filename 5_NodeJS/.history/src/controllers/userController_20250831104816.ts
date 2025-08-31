import express  from "express"

export const userController = express.Router()

// userLogin
userController.get("/", (req, res) => {
    res.render('login')
})
userController.post('/login', (req, res) =>{
    const user = req.body
    console.log('login')
})
