import express from 'express'
import {login, register} from '../services/userService'
import { IUser } from '../models/userModel'
import { body } from 'express-validator'


const userRestController = express.Router()

// Register Validation Kuralları

const registerValidationRules = [
    body('username')
        .isString().withMessage('Username must be a string').notEmpty().withMessage('Username is required')
        .isLength({ min: 3 }).withMessage('Username must be at least 3 characters long'),
    body('email')
        .isString().withMessage('Email must be a string').notEmpty().withMessage('Email is required')
        .isEmail().withMessage('Email must be a valid email address'),
    body('password')
        .isString().withMessage('Password must be a string').notEmpty().withMessage('Password is required')
        .isLength({ min: 6 }).withMessage('Password must be at least 6 characters long')
]

// Login Validation Kuralları

const loginValidationRules = [
    body('username')
        .isString().withMessage('Username must be a string').notEmpty().withMessage('Username is required'),
    body('password')
        .isString().withMessage('Password must be a string').notEmpty().withMessage('Password is required')
]

userRestController.post('/register', registerValidationRules, async (req, res) => {
    const user = req.body as IUser
    const jsonResult = await register(user)
    res.status(jsonResult.code).json(jsonResult)
})

userRestController.post('/login', async (req, res) => {
    const user = req.body as IUser
    const jsonResult = await login(user)
    res.status(jsonResult.code).json(jsonResult)
})

export default userRestController
