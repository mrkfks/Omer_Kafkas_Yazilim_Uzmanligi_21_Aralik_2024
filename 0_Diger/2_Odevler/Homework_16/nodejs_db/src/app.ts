import express from 'express';
import session from 'express-session';
import path from 'path';
import { connectDB } from './utils/db';
import { IUser } from './models/userModel';
import { userController } from './controllers/userController';
import { dashboardController } from './controllers/dashboardController';

const app = express();
const PORT = process.env.PORT || 3000;

// Session Config
declare module 'express-session' {
  interface SessionData {
    item: IUser
  }
}
const sessionConfig = session({
  secret: process.env.SESSION_SECRET || 'key123',
  resave: false,
  saveUninitialized: false,
  cookie: {
    httpOnly: true,
    secure: false, // Prod ortamında true + trust proxy
    maxAge: 1000 * 60 * 60 // 1 saat
  }
});
app.use(sessionConfig);

// DB Config
connectDB();

// EJS Configuration
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

// body-parser Config
app.use(express.urlencoded({ extended: false }));
app.use(express.json());

// Controllers
app.use('/', userController);
app.use('/dashboard', dashboardController);

// Basit health check
app.get('/health', (_req, res) => {
  res.json({ status: 'ok' });
});

// 404 handler
app.use((req, res, next) => {
  res.status(404).render('template/bootstrap', { content: 'Sayfa bulunamadı', title: '404' });
});

// Global error handler
// eslint-disable-next-line @typescript-eslint/no-unused-vars
app.use((err: any, _req: express.Request, res: express.Response, _next: express.NextFunction) => {
  console.error('Hata:', err);
  if (res.headersSent) return;
  res.status(err.status || 500).json({ error: 'İç sunucu hatası' });
});


app.listen(PORT, () => {
  console.log(`Server running: http://localhost:${PORT}`);
});

export default app;

