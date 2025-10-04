import express from "express";
import { AuthRequest, checkRole, verifyToken } from "../configs/auth";
import { eRoles } from "../utils/eRoles";
import Category, { ICategory } from "../models/category"; 
import { JwtPayload } from "jsonwebtoken";

const categoryRestController = express.Router();

// Kategori ekleme
categoryRestController.post(
  "/add",
  verifyToken,
  checkRole(eRoles.Admin),
  async (req: AuthRequest, res) => {
    try {
      const categorydata = req.body as ICategory;

      if (
        !categorydata.name ||
        categorydata.name.length < 2 ||
        categorydata.name.length > 50
      ) {
        return res.status(400).json({ message: "Invalid category name" });
      }

      // Kategori benzersizlik kontrolü
      const existingCategory = await Category.findOne({ name: categorydata.name });
      if (existingCategory) {
        return res.status(409).json({ message: 'Category already exists' });
      }

      const newCategory = new Category(categorydata);
      await newCategory.save();

      return res.status(201).json({
        message: "Category added successfully",
        category: newCategory,
      });
    } catch (error) {
      return res.status(500).json({ message: "Internal server error", error });
    }
  }
);

// Kategori listeleme (10'ar 10'ar)
categoryRestController.get(
  "/list",
  verifyToken,
  checkRole(eRoles.Admin, eRoles.User),
  async (req, res) => {
    try {
      const page = parseInt(req.query.page as string) || 1;
      const limit = 10;
      const skip = (page - 1) * limit;
      const totalCategories = await Category.countDocuments();
      const categories = await Category.find()
        .skip(skip)
        .limit(limit)
        .sort({ createdAt: -1 });

      return res.status(200).json({
        categories,
        page,
        totalPages: Math.ceil(totalCategories / limit),
        totalCategories,
      });
    } catch (error) {
      return res.status(500).json({ message: "Internal server error", error });
    }
  }
);

// Router'ı export et
export default categoryRestController;
