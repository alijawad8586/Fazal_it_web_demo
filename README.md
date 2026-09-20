# Fazal Tech Solutions Website

Angular frontend + ASP.NET Core (.NET 9) backend API.

## Requirements
- Node.js 20+ and npm
- .NET SDK 9

## Run

Backend (API on http://localhost:5269):

```bash
cd backend
dotnet run --launch-profile http
```

Frontend (site on http://localhost:4200), in a second terminal:

```bash
cd frontend
npm install
npx ng serve
```

Open http://localhost:4200. The frontend needs the backend running to show services, blog posts and to send the contact form.

## Structure
- `backend/` — API: `Controllers/` (blog, services, contact), `Models/`, `Services/` (contact messages saved to `App_Data/contact-messages.json`), `Data/SeedData.cs`.
- `frontend/src/app/` — `pages/` (home, services, about, blog, blog-post, contact), `shared/` (header, footer, service icon), `core/` (API services and models).
- `frontend/public/images/` — illustrations and photos (photos from Unsplash, free license).
- The API URL is set in `frontend/src/environments/environment.ts`.

## Other commands
- `npx ng build` — production build (in `frontend/`)
- `npx ng test --watch=false` — unit tests (in `frontend/`)
