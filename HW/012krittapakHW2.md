**comment code smell**

คอมเมนต์ในโค้ดที่มากเกินไปแสดงให้เห็นว่าโค้ดนั้นไม่สามารถอธิบายได้ในตัวของมันเอง 
จึงต้องเขียนคอมเมนต์แทรกลงไป เพื่ออธิบายการทำงานให้กับคนอื่นหรือตัวเราเองที่ต้องกลับมาทำต่อทีหลัง 
แสดงว่าโค้ดนั้นซับซ้อนเกินไปที่จะอ่าน Logic จากโค้ด


**ตัวอย่าง** 
    
    def calc(x, y, z):
    # ตรวจสอบว่า x มากกว่า 0 หรือไม่
    if x > 0:
        # ถ้า y เท่ากับ 1 แปลว่าเป็นโหมดพิเศษ
        if y == 1:
            # คูณ x กับ z แล้วบวก 10
            return x * z + 10
        else:
            # ถ้าไม่ใช่โหมดพิเศษ ให้คูณเฉย ๆ
            return x * z
    else:
        # ถ้า x น้อยกว่าหรือเท่ากับ 0 ให้คืนค่า 0
        return 0


**refactor**
    
    def calculate_price(quantity, is_special_mode, unit_price):
    if quantity <= 0:
        return 0

    if is_special_mode:
        return quantity * unit_price + 10

    return quantity * unit_price


**ตัวอย่างที่ไม่ใช่code smell**
    
    def calculate_late_fee(days_late):
    """
    Business rule:
    - ปรับค่าปรับเฉพาะวันที่เกิน 14 วัน
    - อัตราค่าปรับ 12 USD ต่อวัน
    - ใช้กับลูกค้าบางรายเท่านั้น (ดูจาก upstream logic)
    """

    # กฎหมายภายในบริษัทกำหนดว่า 14 วันแรก "ห้ามคิดค่าปรับ"
    FREE_DAYS = 14

    # อัตรานี้มาจากสัญญาเลขที่ CN-2024-07
    FEE_PER_DAY = 12

    if days_late <= FREE_DAYS:
        return 0

    return (days_late - FREE_DAYS) * FEE_PER_DAY


