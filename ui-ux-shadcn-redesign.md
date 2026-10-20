# Plan: UI/UX Redesign to Shadcn Theme (WPF) - COMPLETED

## Context
Update the SkillForge WPF application UI/UX from basic emojis and inconsistent colors to a modern, professional **Shadcn Zinc** theme. The new design replaces all emoji icons with clean XAML Vector Path Geometries (Lucide-inspired), implements consistent Light and Dark modes with dynamic color tokens, and polishes all views with subtle 1px borders, balanced typography, and clean cards.

---

## Tasks Status

### 1. Design System Tokens & Vector Geometries (`App.xaml` & `App.xaml.cs`) - [COMPLETED]
- Defined full set of Shadcn Zinc semantic tokens (`BackgroundBrush`, `CardBgBrush`, `TextPrimaryBrush`, `TextSecondaryBrush`, `BorderBrushColor`, `PrimaryBtnBgBrush`, `SidebarBgBrush`, `BadgeNeutralBgBrush`, `BadgeSuccessBgBrush`, etc.).
- Added reusable XAML Path Geometries for Lucide icons (Dashboard, Briefcase, Folder, Kanban, Sparkles, Sun, Moon, Search, Plus, Download, CheckCircle, Building, Bookmark, Send, Calendar, Award).
- Updated `App.ToggleTheme()` to switch between Shadcn Zinc Dark (`#09090B` / `#121215`) and Light (`#FAFAFA` / `#FFFFFF`).

### 2. Main Window & Modern Shadcn Sidebar (`MainWindow.xaml` & `MainViewModel.cs`) - [COMPLETED]
- Redesigned sidebar: Brand logo with vector `GeomSparkles`, navigation buttons with vector icons and active-state hover styling.
- Replaced database status with clean `GeomCheckCircle` badge.
- Replaced profile card and theme switch button with clean `GeomMoon` vector glyph (no emojis).

### 3. Dashboard View Redesign (`DashboardView.xaml`) - [COMPLETED]
- Removed "🚀" and "🏢" emojis.
- Re-architected hero banner into a high-contrast Shadcn zinc card with clean typography.
- Styled 4 KPI metric cards with 1px zinc borders and Lucide vector icons.
- Modernized recommended internship card and DataGrid with clean headers and row separators.

### 4. Projects View Redesign (`ProjectsView.xaml` & `AddProjectWindow.xaml`) - [COMPLETED]
- Removed "📥" and "+" emojis; used vector `GeomDownload` and `GeomPlus`.
- Modernized search input with subtle 1px border and Lucide `GeomSearch` icon container.
- Updated `AddProjectWindow` modal dialog to match Shadcn dialog styles.

### 5. Readiness Assessment View Redesign (`ReadinessView.xaml`) - [COMPLETED]
- Removed hardcoded colors (`#0F172A`, `White`, `#F8FAFC`); bound all elements to dynamic resources.
- Removed "🔍" emoji and styled primary CTA button.
- Redesigned score metric card and skills checklist with vector award and status indicators.

### 6. Application Pipeline Kanban Redesign (`PipelineView.xaml`) - [COMPLETED]
- Replaced hardcoded column backgrounds with `InnerCardBgBrush` and cards with `CardBgBrush`.
- Replaced emojis (⭐, 📤, 🎯, 🎉) with Lucide-style badges (`GeomBookmark`, `GeomSend`, `GeomCalendar`, `GeomAward`).
- Modernized pipeline stage headers and card metadata typography.

### 7. Verification & Build Validation - [COMPLETED]
- Ran `dotnet build SkillForge/SkillForge.csproj` -> Build succeeded with 0 errors.
- Verified application launches and runs smoothly in Windows.
