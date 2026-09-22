TRUSTID PREMIUM FORM REDESIGN

This version uses the original TrustID project and keeps the original business logic/event handlers.
The redesign is applied AFTER InitializeComponent(), so the existing WinForms controls remain real and functional.

What changed:
- New light/dark background PNGs based on the approved TrustID design board.
- Existing real controls are restyled and, where needed, moved into clearer positions.
- No fake textboxes, fake buttons, fake tables or fake data are baked into the backgrounds.
- A theme toggle is added visually; it only changes the design theme.
- The existing authentication, verification, transactions, reviews, models and services were not rewritten.

Main visual file:
PremiumFormDesign.cs

Backgrounds:
Resources\PremiumForm

To remove the redesign:
1. Remove PremiumFormDesign.cs.
2. Remove Resources\PremiumForm.
3. Remove the PremiumFormDesign.Apply(...) lines added after InitializeComponent().
The original Designer control definitions and event handlers remain in place.
